using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class HelloWorld
{
    public class iQueue
    {
        int[] imitQueue;
        int currentPoint = 0;
        
        public iQueue()
        {
            int SizeQueue = 100;
            imitQueue = new int[SizeQueue];
        }

        public void resizeP()
        {
            for (int i = currentPoint; i > 0; i--)
            {
                imitQueue[i + 1] = imitQueue[i];
                imitQueue[i] = 0;
            }
        }

        public void resizeM()
        {
            for (int i = 0; i <= currentPoint; i++)
            {
                imitQueue[i] = imitQueue[i+1];
                imitQueue[i+1] = 0;
            }
        }

        public void push(int n)
        {
            resizeP();
            imitQueue[0] = n;
            Console.WriteLine("ok");
            currentPoint++;
        }
        public int pop()
        {
            
            int returnValue = imitQueue[0];
            resizeM();
            currentPoint--;
            return returnValue;
        }
        public int front()
        {
            int bVal = imitQueue[0];
            return bVal;
        }
        public int size()
        {
            int curPoint = currentPoint--;
            currentPoint++;
            return curPoint;
        }
        public void clear()
        {
            currentPoint = 0;
            Console.WriteLine("ok");
        }
        public void exit()
        {
            Console.WriteLine("bye");
        }

    }

    static void Main()
    {

        iQueue imitQueue = new iQueue();

        for (; ; )
        {
            String code;

            Console.WriteLine("push - внести элемент в стек (После внесения 'push' нажать enter и только затем внести число)");
            Console.WriteLine("pop - удалить верхний элемент массива");
            Console.WriteLine("front - вывод последнего элемента");
            Console.WriteLine("size - размер стека");
            Console.WriteLine("clear - очистить стек");
            Console.WriteLine("exit - выход");

            Console.Write("Code - ");
            code = Console.ReadLine();
            int dataOutput;

            switch (code)
            {
                case "push":
                    int sinAct;
                    sinAct = Convert.ToInt32(Console.ReadLine());
                    imitQueue.push(sinAct);
                    break;

                case "pop":
                    dataOutput = imitQueue.pop();
                    Console.WriteLine(dataOutput);
                    break;

                case "front":
                    dataOutput = imitQueue.front();
                    Console.WriteLine(dataOutput);
                    break;

                case "size":
                    dataOutput = imitQueue.size();
                    Console.WriteLine(dataOutput);
                    break;

                case "clear":
                    imitQueue.clear();
                    break;

                case "exit":
                    imitQueue.exit();
                    return;

                default:
                    Console.WriteLine("Error, Incorrect command entered");
                    break;
            }
        }
    }
}