// linkedlist demo :

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoding 
{
   class Node 
	{
		public int data;
		public Node next;
		 
		public Node(int data)
		 {
			this.data = data; 
			this.next = null;
		 }
		 
		  
	}
	
	
  class DemoLinkedlist
   {
	static void Main(string[] args)
        { 
		
           Node head = null;
		    // Node node1 = new Node(5);
		    // head = node1;
		   
		    // Node node2 = new Node(6);
		    // node1.next= node2;
		   
		    // Node node3 = new Node(7);
		    // node2.next= node3;
			
		   addNodeBegin(head,7);
		   addNodeBegin(head,5);
		   displayNode(head);
		   
		 }  
		 
		 public static void displayNode(Node head)
		 {
			 Node temp;
			 temp = head;
			 while(temp != null)
			 {
				Console.Write(temp.data + "->");
				temp = temp.next;
			 }
			 
		 }	
		 
		  public static void addNodeBegin(Node head,int data)
		  {
			 Node temp = new Node(data);
			 temp.next = head;
			 head = temp;
			 
			 
		  }	

    
        
    }
}