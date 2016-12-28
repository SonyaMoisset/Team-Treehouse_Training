import java.util.Date;

import com.teamtreehouse.Treet;

public class Example {
  
  public static void main(String[] args) {
    Treet treet = new Treet(
      "sonyamoisset",
      "Want to be famous? Simply tweet about Java and use the hashtag #treet. I'll use your tweet in a new @treehouse course about data structures.",
      new Date(1421849732000L)
    );
    System.out.printf("This is a new Treet: %s %n", treet);
  }
}
