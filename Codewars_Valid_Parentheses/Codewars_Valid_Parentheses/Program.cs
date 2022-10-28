using System;

namespace Valid_Parentheses
{
    class Program
    {
        public static void IsValid(string parent)
        {
            /* int count = 0;
             int x = 0;

             for (int i = 0; i < parent.Length; i++)
             {
                 if (parent[i] == '(')
                     count--;
                 if (parent[i] == ')')
                     count++;
                 if (parent.IndexOf(")") < parent.IndexOf("("))
                     x++;
             }
             if (parent.IndexOf(')') < parent.IndexOf('(')
                 return false;

             if (count > 0 || x > 0) 
                 Console.WriteLine("False");

             else
             {
                 count = 0;
                 Console.WriteLine("True");
             }*/


            string[] brackArr = parent.Split();
            int count = 0; ;
            if (brackArr.Length % 2 == 1)
            {
                Console.WriteLine("false");
            }

            /*while(brackArr.Length !=0)
            {

                count++;
                Console.Write(brackArr.Length);
            }
            Console.Write(count);*/

        }


        public static void Main(string[] args)
        {
            //IsValid("()");
            //IsValid("((()))))");
            //sValid("(()))))");
            IsValid("hi)()()(((( ");
        }
    }
}
/*
 * 
 * 
 * 
 * string prop = "";
        while(input.Length != prop.Length)
          {
            prop = input;
            input = input
              .Replace("()", string.Empty);
          }
        return (input.Length == 0);
 * 
 * 
 */


/*int count = 0;
for (int i = 0; i < input.Length; i++)
  {
    if(input[i] == '(')
      count++;
    if(input[i] == ')' )
      count--;
  }
    if(count > 0)
      return false;
return count == 0;

Stack<char> left = new Stack<char>();
foreach (char c in input.ToCharArray())
{
if (c == '(' || c == ' ')
{
  left.Push(c);
}
else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
{
  left.Pop();
}
else return false;
return true;*/



/*Stack <char> left = new Stack<char>();

  foreach(char c in input.ToCharArray()) 
  {
      if (c == '(' || c == ' ' ) 
           {
             left.Push(c);
           }
     else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(' )
           {
             left.Pop();
           } 
    //else if(c == '(' && left.Count != 0 && (char)left.Peek() == ')' )
           //{
             //left.Pop();
           //} 
      else 
          return false;
    if (input.IndexOf(')') < input.IndexOf('('))
        return false;
  }
  return true;*/

/*Stack<char> s = new Stack<char>();
char[] arr = input.ToCharArray();
int i = 0;
while (i < input.Length)
{
    if (input.IndexOf(')') < input.IndexOf('('))
        return false;
    if (arr[i] == '(')
        s.Push(arr[i]);
    if (arr[i] == ')')
    {
        if (s.Count == 0)
        {
            return false;
        }
        else if (s.Peek() == '(' && arr[i] == ')')
        {
            return true;
        }

        else
            return false;
    }
    i++;
}
if (s.Count == 0)
    return true;
return false;*/


/*int count = 0;
for (int i = 0; i < input.Length; i++)
  {
    if(input[i] == '(')
      count++;
    if(input[i] == ')' )
      count--;
    //if(input[i] == ')' && count  != 0)
      //return false;
  }
    if(count > 0)
      return false;
else
count = 0; 
return true;
}*/



/*int n = -1;
  while (input.Length != n) 
    {
        n = input.Length;
        input = input.Replace("()", "");
    }
  if (input.Length == 0) 
    return true;
  else 
    return false;*/



/*Stack <char> stack = new Stack <char>();

//for(int i = 0;i < input.Length;i ++){
    //char c = input.charAt(i);
  foreach (char c in input.ToCharArray())
    {
    if(c == '(' ){
        stack.push(c);
    }
    else if(!stack.empty() && ((c == ')' && stack.peek() == '(')))
      {
          stack.pop(); 
      }
    else
      {
        return false;
      }
}
return stack.empty();*/


/*Stack<char> s = new Stack<char>();
      char[] arr = input.ToCharArray();
      int i = 0;
      while (i < input.Length)
      {
          if(input.IndexOf(')') < input.IndexOf('('))
                return false;
          if (arr[i] == '(')
              s.Push(arr[i]);
          if (arr[i] == ')')
          {
              if (s.Count == 0)
                {
                  return false;
                }
              else if(s.Peek() == '(' && arr[i] == ')')
                {
                  return true;
                }

              else
              return false;
          }
          i++;
      }
      if (s.Count == 0)
         return true;
      return false;*/

/*int count = 0;
int x = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
        count--;
    if (input[i] == ')')
        count++;
    if (input.IndexOf(')') < input.IndexOf('('))
        x++;
}
if (count > 0 || x > 0) 
    return false;
else
    count = 0;
return true;*/


/*int count = 0;
for (int i = 0; i < input.Length; i++)
{
 if(input[i] == '('  )
   count++;
 if(input[i] == ')' )
   count--;
 if(input[i] == ')' && count !=0)
   return false;
}
 if(count > 0)
   {
   return false;
   }
return count == 0; 
 return true;*/
