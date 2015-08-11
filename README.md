# UX
UX Framework

## Getting started

### Basic template
Start with this basic HTML template, or modify, adapting them to suit your needs.

Copy the HTML below to begin working with a minimal Framework document.
```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Theme Template for Framework</title>
    <!-- Framework core CSS -->
    <link href="Theme/Style/theme.min.css" rel="stylesheet" />
    <!-- Framework core Javascript -->
    <script type="text/javascript" src="Theme/Scripts/framework.js"></script>
    
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>

<body>

</body>
</html>	
```

### Add header
Add following HTML in ```<body>``` tag in above template file.
```html
    <div>  
		<!-- Header starts -->
		<header id="page-header" data-ux-role="header">			
		</header>
		<!-- Header ends -->
		
	</div>
```
# Basic header initiation
Add following code just before end of ```</body>``` tag.
```html
    <script>
		$(function(){
		    // Initiate header.
			$("#page-header").uxHeader();	
		});
	</script>
```



