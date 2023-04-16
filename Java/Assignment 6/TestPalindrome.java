import java.util.Scanner;

public class TestPalindrome {
    QueueAsMyLinkedList<Character> queue = new QueueAsMyLinkedList<>();
    StackAsMyLinkedList<Character> stack = new StackAsMyLinkedList<>();


    public void pushCharacter(char ch) {
        stack.push(ch);
    }

    public char popCharacter() {
        return (char) stack.pop();
    }

    // Queue
    public void enqueueCharacter(char ch) {
        queue.enqueue(ch);
    }

    public char dequeueCharacter() {
        return (char) queue.dequeue();
    }

    public static void main(String[] args) {
        System.out.println("Enter something: ");
        Scanner sc = new Scanner(System.in);
        String input = sc.next();


        // Converting input String to an array of characters:
        char[] s = input.toCharArray();

        // Creating a Solution object:
        TestPalindrome p = new TestPalindrome();

        // Enqueue/Push all chars to their respective data structures:
        for (char c : s) {
            p.pushCharacter(c);
            p.enqueueCharacter(c);
        }

        // Pop/Dequeue the chars at the head of both data structures and compare them:
        boolean isPalindrome = true;
        for (int i = 0; i < s.length / 2; i++) {
            if (p.popCharacter() != p.dequeueCharacter()) {
                isPalindrome = false;
                break;
            }
        }

        // Finally, printing whether string s is palindrome or not.
        System.out.println("The word, " + input + ", is " + ((!isPalindrome) ? "not a palindrome." : "a palindrome."));
    }
}