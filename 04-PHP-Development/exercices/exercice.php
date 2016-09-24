<?php 

  $exercise1 = 'Display "Hello World!"';
  $exercise2 = 'Convert Pounds to Kilograms';
  $exercise3 = 'Convert Kilograms to Pounds';
  $exercise4 = 'Convert Miles to Kilometers';
  $exercise5 = 'Convert Kilometers to Miles';
  $exercise6 = 'Month long string of the day';
  $exercise7 = 'String of the day with levels';
  
  $day = date('N');
  $day = 6;
  
  if ($day == 1) {
    echo $exercise1;
  } else if ($day == 2) {
    echo $exercise2;
  } else if ($day == 3) {
    echo $exercise3;
  } else if ($day == 4) {
    echo $exercise4;
  } else if ($day == 5) {
    echo $exercise5;
  } else if ($day == 6) {
    echo $exercise6;
  } else if ($day == 7) {
    echo $exercise7;
  }

?>
