<head>

<?php
    $width="";
    $height="";
if(isset($_GET['submit'])){


    $width = $_GET['width'];
    $height = $_GET['height'];

}
?>

</head>

<body>

    <form action="divwidthheight.php" method="get">

        <input type="text" name="width" id="width" value="<?php echo $width ?>">
        <input type="text" name="height" id="height" value="<?php echo $height ?>">
        <input type="submit" name="submit" value="submit">

    </form> 

    <div style="width: <?php echo $width; ?>; height: <?php echo $height; ?>; background-color: black" />


</body>
