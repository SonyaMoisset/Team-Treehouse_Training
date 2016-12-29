package com.teamtreehouse;

import java.io.*;

public class Treets {
  
  public static void save(Treet[] treets) {   
    try (
      FileOutputStream fos = new FileOutputStream("treets.ser");
      ObjectOutputStream oos = new ObjectOutputStream(fos);
    ) {
      oos.writeObject(treets);
    } catch (IOException ioe) {
      System.out.println("Problem saving Treets");
      ioe.printStackTrace();
    }
  }
  
  public static Treet[] load() {
    Treet[] treets = new Treet[0];
    
    try (
      FileInputStream fis = new FileInputStream("treets.ser");
      ObjectInputStream ios = new ObjectInputStream(fis);
    ) {
      treets = (Treet[]) ios.readObject();
    } catch (IOException ioe) {
      System.out.println("Error reading file");
      ioe.printStackTrace();
    } catch (ClassNotFoundException cnfe) {
      System.out.println("Error loading treets");
      cnfe.printStackTrace();
    }
    return treets;
  }
}
