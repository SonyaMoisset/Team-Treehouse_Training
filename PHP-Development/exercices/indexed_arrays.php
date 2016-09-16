<?php 

  $learn = array('Conditionals', 'Arrays', 'Loops');
  $learn[] = 'Build something awesome';
  array_push($learn, 'Functions', 'Forms', 'Objects');
  array_unshift($learn, 'HTML', 'CSS');
  
  echo 'you removed ' . array_shift($learn);
  echo 'you removed ' . array_pop($learn);
  unset($learn[1], $learn[2]);
  $learn = array_values($learn);
  //$learn = 'my learning list';
  $learn[0] = 'Email';
  
  var_dump($learn);
  //echo $learn[1];
  //echo $learn;
  //echo implode("\n",$learn);

?>
