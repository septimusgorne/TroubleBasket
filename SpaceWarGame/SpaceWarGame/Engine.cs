using SpaceWarGame.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    /*internal class Engine
    {
    }*/

    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<MovingObject> alienShips;
        List<GameObject> staticObjects;
        List<GameObject> menuItems;
        List<GameInformation> gameInfoFields;
        PlayerShip playerShip;
        Cursor cursor;
        int sleepTime;
        public bool isPaused = true;

        static Random randomGenerator = new Random();

        public Engine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.alienShips = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.menuItems = new List<GameObject>();
            this.gameInfoFields = new List<GameInformation>();
            this.sleepTime = 100;
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int sleepTime)
            : this(renderer, userInterface)
        {
            this.sleepTime = sleepTime;
        }

        public virtual void AddObject(GameObject newObj)
        {
            try
            {
                if (newObj is MovingObject)
                {
                    this.AddMovingObject(newObj as MovingObject);
                }

                else if (newObj is PlayerShip)
                {
                    this.AddPlayer(newObj);
                }

                else if (newObj is Cursor)
                {
                    this.AddCursor(newObj);
                }

                else if (newObj is MenuItem)
                {
                    AddMenuItem(newObj);
                }

                else if (newObj is GameInformation)
                {
                    this.gameInfoFields.Add(newObj as GameInformation);
                    this.allObjects.Add(newObj);
                }

                else if (!(newObj is MovingObject))
                {

                    this.AddStaticObject(newObj);
                }

                else
                {
                    throw new InvalidEngineObjectException("The object cannot be added to engine.");
                }
            }
            catch (InvalidEngineObjectException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddMenuItem(GameObject newObj)
        {
            this.staticObjects.Add(newObj);
            this.allObjects.Add(newObj);
            this.menuItems.Add(newObj);
        }

        private void AddCursor(GameObject newObj)
        {
            this.allObjects.Remove(this.cursor);
            this.staticObjects.Remove(this.cursor);
            this.cursor = newObj as Cursor;
            this.AddStaticObject(newObj);
        }

        private void AddPlayer(GameObject newObj)
        {
            this.allObjects.Remove(this.playerShip);
            this.staticObjects.Remove(this.playerShip);
            this.playerShip = newObj as PlayerShip;
            this.AddStaticObject(newObj);
        }

        private void AddStaticObject(GameObject newObj)
        {
            this.staticObjects.Add(newObj);
            this.allObjects.Add(newObj);
        }

        private void AddMovingObject(MovingObject newObj)
        {
            this.movingObjects.Add(newObj);
            if (newObj is AlienShip)
            {
                this.alienShips.Add(newObj);
            }
            this.allObjects.Add(newObj);
        }

        public virtual void MoveCursorUp()
        {
            cursor.MoveUp();
        }

        public virtual void MoveCursorDown()
        {
            cursor.MoveDown();
        }

        public virtual void CursorAction()
        {
            foreach (MenuItem item in this.menuItems)
            {
                if (item.TopLeft.Row == this.cursor.TopLeft.Row)
                {
                    item.TakeAction(this);
                }
            }
        }

        public virtual void MovePlayerShipLeft()
        {
            if (this.playerShip.TopLeft.Col > 1)
            {
                playerShip.MoveLeft();
            }
        }

        public virtual void MovePlayerShipRight()
        {
            if (this.playerShip.TopLeft.Col < this.renderer.GetWidth() - 22)
            {
                playerShip.MoveRight();
            }
        }

        public virtual void Shoot()
        {
            this.playerShip.IsShooting = true;
        }

        public void GameOver()
        {
            GameInformation gameOver = new GameInformation(new MatrixPosition(11, 54), "Game Over!");
            this.AddObject(gameOver);

        }

        public virtual void Pause()
        {
            while (true)
            {
                this.renderer.RenderAll();
                System.Threading.Thread.Sleep(this.sleepTime);

                this.userInterface.PauseProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    this.renderer.EnqueueForRendering(obj);
                }
            }
        }

        public virtual void Run()
        {
            this.isPaused = false;

            while (true)
            {
                if (this.playerShip.IsDestroyed)
                {
                    this.GameOver();
                    break;
                }

                this.renderer.RenderAll();


                foreach (var info in this.gameInfoFields)
                {
                    if (info is Score)
                    {
                        info.RefreshMessage("Score: " + this.playerShip.Score);
                    }
                    if (info is Lifes)
                    {
                        string lifes = "";
                        for (int i = 0; i < this.playerShip.Life; i++)
                        {
                            lifes += '♥';
                        }
                        info.RefreshMessage("Lifes: " + lifes);
                    }
                }

                System.Threading.Thread.Sleep(this.sleepTime);
                int count = 0;
                count++;
                this.userInterface.RunProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(movingObjects, staticObjects, alienShips, playerShip);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);
                this.alienShips.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}
