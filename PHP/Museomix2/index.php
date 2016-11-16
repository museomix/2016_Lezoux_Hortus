<!-- <?php
$page = $_SERVER['PHP_SELF'];
$sec = "10";
?>
 -->
<!doctype html>
<html class="no-js" lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="refresh" content="<?php echo $sec?>;URL='<?php echo $page?>'">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hortus</title>
    <link rel="stylesheet" href="css/app.css">
  </head>
  <body>

  <div class="row expanded grid small-up-1 large-up-6">

  <?php 
    $images = glob('img/*.{jpg,png,gif, svg}', GLOB_BRACE);
    
    shuffle($images);

    $attributes = array("larger", "smaller", "", "", "", "");

    $i = 0;
    
    foreach($images as $image) {
      
      if ($i < 200) {
        
        shuffle($attributes);
        
        ?><div class="grid-item column end <?php echo $attributes[0]; ?>"><?php
        
        echo '<img src="'.$image.'">';
        
        ?></div><?php
      }
      
      $i++;
    
    }
  ?>

  </div>

    <script src="bower_components/jquery/dist/jquery.js"></script>
    <script src="bower_components/what-input/what-input.js"></script>
    <script src="bower_components/foundation-sites/dist/foundation.js"></script>
    <script src="bower_components/packery/dist/packery.pkgd.min.js"></script>
      <script src="bower_components/jquery/dist/jquery.js"></script>
    <script src="js/app.js"></script>
    <script src="js/masonry.pkgd.min.js"></script>
  
  </body>
</html>
