<?php 

  $a = 10;
  $b = 10;
  
  if ($a == $b) {
    echo 'values are equal';
  } else {
    echo 'values are NOT equal';
  }
  
  if ($a <= $b) {
    echo 'values are NOT equal';
  }
  
  if ($a != $b) {
    echo 'values are NOT equal';
  } 
  
  if ($a !== $b) {
    echo 'values are NOT identical';
  } 
  
  if ($a) {
    echo 'true';
  }
  
  if (!$a) {
    echo 'false';
  }
  
  if ($a == false) {
    echo 'false';
  }
  
  if ($a != true) {
    echo 'false';
  }



  /* if ($a == $b) {
    echo ' values are equal ';
  } else if ($a < $b) {
    echo ' $a is less than $b ';
  } else if ($a > $b) {
    echo ' $a is greater than $b ';
  }else {
    echo ' valuers are NOT equal ';
  } */

  $num = 10000;

  if ($num >= 10) {
    if ($num <= 1000) {
      echo 'your number is within the range';
    } else {
      echo 'your number is greater than 1000, NOT within the range';
    }
  } else {
    echo 'your number is less than 10, is NOT within the range';
  }


  $num = 20;

  if ($num >= 10 AND $num <= 1000) {
    echo 'your number is within the range';
      } else {
    echo 'your number is less than 10, is NOT within the range';
  }

 if ($num >= 10 OR $num <= 1000) {
    echo 'your number is within the range';
      } else {
    echo 'your number is less than 10, is NOT within the range';
  }

  $var1 = true && false;
  $var2 = true and false;
  
  var_dump($var1,$var2);
?>
