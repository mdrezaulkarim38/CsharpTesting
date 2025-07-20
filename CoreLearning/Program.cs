using System;

public class Node {
    public int Data;
    public Node Next;

    public Node(int data) {
        this.Data = data;
        this.Next = null;
    }
}

public class LinkedList {
    private Node head;

    public void Add(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    public void Print() {
        Node temp = head;
        while (temp != null) {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}

class Program {
    static void Main() {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(50);
        list.Print();
    }
}