public class Example {
    
    public static void main(String[] args) {
      
        System.out.println("We are making a new Pez Dispenser.");
        PezDispenser dispenser = new PezDispenser("Yoda");
        System.out.printf("The dispenser character is %s.\n", dispenser.getCharacterName());
    }
}
