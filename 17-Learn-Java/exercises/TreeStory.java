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
      String ageAsString = console.readLine("How old are you? ");
      int age = Integer.parseInt(ageAsString);
      if (age < 13) {
        // Insert exit code
        console.printf("Sorry you must be at least 13 to use this program.\n");
        System.exit(0);
      }
      
      String name = console.readLine("Enter a name: ");
      String adjective = console.readLine("Enter an adjective: ");
      
      String noun;
      boolean isInvalidWord;
      do {
        noun = console.readLine("Enter a noun: ");
        isInvalidWord = (noun.equalsIgnoreCase("dork") || 
                                 noun.equalsIgnoreCase("jerk"));
        if (isInvalidWord) {
          console.printf("That language is not allowed. Try agai. \n\n");
        }
      } while(isInvalidWord);
      
      String adverb = console.readLine("Enter an adverb: ");
      String verb = console.readLine("Enter a verb ending in -ing: ");
      
      console.printf("Your TreeStory:\n----------\n");
      console.printf("%s is a %s %s.   ", name, adjective, noun);
      console.printf("They are always %s %s.\n", adverb, verb);
    }
    
}
