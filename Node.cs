using System;

namespace BinaryTreeExample
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }
        public bool FindValueIsNull { get; set; }

        public Node(int value)
        {
            Data = value;
        }

        /*
        Поиск в двоичном дереве поиска определенного ключа может быть запрограммирован рекурсивно или итеративно .
        Начнем с изучения корневого узла . Если дерево пустое , ключ, который мы ищем, не существует в дереве. 
        В противном случае, если ключ равен ключу корня, поиск будет успешным и мы вернем узел. Если ключ меньше, чем у корня, мы ищем левое поддерево. Точно так же, если ключ больше, чем у корня, мы ищем правое поддерево. 
        Этот процесс повторяется до тех пор, пока ключ не будет найден или оставшееся поддерево не станет нулевым . 
        Если искомый ключ не найден после достижения нулевого поддерева, значит, ключ отсутствует в дереве. Это легко выразить как рекурсивный алгоритм 
        */

        public Node Find(int value)
        {
            //Стартовый узел
            Node currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.Data)//если номер статьи равен значению узла
                {
                    if(currentNode.RightNode != null)
                    {
                        return currentNode.RightNode;
                    }
                    if(currentNode.RightNode == null)
                    {
                        currentNode.FindValueIsNull = true;
                        return currentNode;//Статья не найдена
                    }
                }
                else if (value > currentNode.Data)//если номер статьи больше значения узла, перейдите к правому дочернему элементу
                {
                    currentNode = currentNode.RightNode;
                }
                else// если номер статьи меньше данных текущего узла, перейти к левому дочернему узлу
                {
                    currentNode = currentNode.LeftNode;
                }
            }
            //Статья не найдена
            currentNode.FindValueIsNull = true;
            return currentNode;
        }

        public void Insert(int value)
        {

            if (value >= Data)
            {   
                if (RightNode == null)
                {
                    RightNode = new Node(value);
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node(value);
                }
                else
                {
                    LeftNode.Insert(value);
                }
            }
        }

    }
}