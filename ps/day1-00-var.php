<?php
    //定义变量
    $var1 = 0;
    $var2 = 2;
    //访问变量
    echo $var2;
    //修改变量
    $var2 = 5;
    echo '<hr/>',$var2;
    //删除变量
    unset($var2);
    //echo $var2;

//变量命名规则
$var_1 = 0;$var_var_1 = 0;
$中国 = 'china';
echo $中国;
echo '<hr/>';

$var_S = 'b';
$b = 'bb';
echo '<hr/>',$b;
echo '<hr/>';
echo $$var_S;