<?php
//值传递
$a = 10;
$b = $a;
$b = 5;
echo $a,'<hr/>',$b;
echo '<br>';
//引用传递
$c = 20;
$d = &$c;
$c = 35;
echo $c,'<hr/>',$d;