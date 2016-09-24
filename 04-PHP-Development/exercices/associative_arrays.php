<?php 

  $iceCream = array(
    'Alena'         => 'Black Cherry', 
    'Treasure'      => 'Chocolate', 
    'Dave'          => 'Cookie and Cream', '
    Rialla'         => 'Strawberry'
  );
  
  //extract($iceCream);
  //echo $iceCream['Alena'];
  
  $iceCream['David'] = 'Cookie Dough';
  $iceCream[] = 'vanilla';
  $iceCream['Andrew'] = true;
  var_dump($iceCream);
  
  $keys = array(
    1 => 'a',
    '1' => 'b',
    1.5 => 'c',
    true => 'd'
  );
  
  var_dump($keys);

?>
