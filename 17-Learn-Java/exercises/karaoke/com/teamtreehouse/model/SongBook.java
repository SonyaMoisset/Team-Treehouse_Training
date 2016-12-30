package com.teamtreehouse.model;

import java.util.ArrayList;
import java.util.List;

public class SongBook {
  private List<Song> mSongs;
  
  public SongBook() {
    mSongs = new ArrayList<Song>();
  }
  
  public void addSong(Song song) {
    mSongs.add(song);
  }
  
  public int getSongCount() {
    return mSongs.size();
  }
}
