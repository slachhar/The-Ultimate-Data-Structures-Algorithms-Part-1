import org.w3c.dom.Node;

public class LinkedList {
    private class Node {
        private int value;
        private Node next;

        public Node(Node item) {
            this.value = item.value;
            this.next = item.next;
        }
    }
    private Node head;
    private Node tail;
    private int count;

    public void addFirst(Node item){
        var node = new Node(item);
        if(head == null){
            head = node;
            tail = head;
        }
        else {
            node.next = head;
            head = node;
        }
    }

    public void addLast(Node item) {
        Node node = new Node(item);
        if (tail == null) {
            head = node;
            tail = head;
        } else {
            tail.next = node;
            tail = node;
        }
    }
}
