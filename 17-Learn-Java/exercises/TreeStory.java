import java.io.Console;
 
public class TreeStory {
    
    public static void main(String[] args) {
        Console console = System.console();
        /*  Some terms:
            noun - Person, place or thing
            verb - An action
            adjective - A description used to modify or describe a noun
            Enter your amazing code here!
        */
      // __Name__ is a __adjective__ __noun__. Theyre are always __adverb__ __verb__.
      String name = console.readLine("Enter a name: ");
      String adjective = console.readLine("Enter an adjective: ");
      String noun = console.readLine("Enter a noun: ");
      String adverb = console.readLine("Enter an adverb: ");
      String verb = console.readLine("Enter a verb ending in -ing: ");
      
      console.printf("Your TreeStory:\n----------\n");
      console.printf("%s is a %s %s.   ", name, adjective, noun);
      console.printf("They are always %s %s.\n", adverb, verb);
    }
    
}
