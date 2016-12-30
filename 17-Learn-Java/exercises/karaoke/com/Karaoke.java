import com.teamtreehouse.model.Song;
import com.teamtreehouse.model.SongBook;

public class Karaoke {
  
  public static void main(String[] args) {
    
    Song song = new Song(
      "Michael Jackson",
      "Beat It",
      "https://www.youtube.com/watch?v=SaEC9i9QOvk");
    SongBook songBook = new SongBook();
    System.out.printf("Adding %s %n", song);
    
    songBook.addSong(song);
    System.out.printf("There are %d songs. %n", songBook.getSongCount());
  }
}
