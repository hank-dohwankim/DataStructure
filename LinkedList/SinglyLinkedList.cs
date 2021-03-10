using System;

public class SinglyLinkedList<T>
{
	private SinglyLinkedListNode<T> head;

    public void Add(SinglyLinkedListNode<T> newNode)
    {
		// if list is empty
		if(head == null)
        {
			head = newNode;
        }
        else
        {
            var current = head;
            // move last node and add new
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void AddAfter(SinglyLinkedListNode<T> current, SinglyLinkedListNode<T> newNode)
    {
        if(head == null || current == null || newNode ==null)
        {
            throw new InvalidOperationException();
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void Remove(SinglyLinkedListNode<T> removeNode)
    {
        if(head == null || removeNode == null)
        {
            return;
        }

        // if delete first node
        if(removeNode == head)
        {
            head = head.Next;
            removeNode = null;
        }
        else
        {
            var current = head;

            // search previous node
            while(current != null && current.Next != removeNode)
            {
                current = current.Next;
            }

            if(current != null)
            {
                // assgin deleted node's next to previous node's Next
                current.Next = removeNode.Next;
                removeNode = null;
            }
        }
    }

    public SinglyLinkedListNode<T> GetNode(int index)
    {
        var current = head;

        for(int i = 0; i< index && current != null; i++)
        {
            current = current.Next;
        }

        // if index is bigger than count, return null
        return current;
    }

    public int Count()
    {
        int count = 0;

        var current = head;

        while(current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }
}