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


## Add header
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
# header initiation with logo
Replace ```$("#page-header").uxHeader();``` with following code.
```javascript
	$("#page-header").uxHeader({
		headerBrandUrl : "images/PeddleLogo.png"				
	});	
```
# header initiation with menu
Update code in  ```$("#page-header").uxHeader({});``` with following code.

Here headerNavContent parameter is used to create and set menu in header. It accepts an array of object. Each objects can have following keys :
- type : ("link"/"button")
- text : (Text to be shown on link)
- url : (URL to be linked with link)
- id: (Unique Id for a link)
- cntClass : (CSS class to attach to link)
- tooltipContent : (If tooltip is required on link, pass tootip object structure describled below else keep it blank)

```javascript
	$("#page-header").uxHeader({
		headerBrandUrl : "images/PeddleLogo.png",
		headerNavContent :[
			{
				type : "link",
				text : "Support",
				url : "#",
				id : "support",			
				cntClass : "",					
				tooltipContent : [{
					tooltipLinkText : "(877) 586-5692",
					tooltipLinkUrl : "tel:8775865692",
					tooltipLinkId : "",
					tooltipLinkIcon : "icon-phone",
				},
				{
					tooltipLinkText : "Chat",
					tooltipLinkUrl : "#",
					tooltipLinkId : "",
					tooltipLinkIcon : "icon-chat-1",
				},
				{
					tooltipLinkText : "Help center",
					tooltipLinkUrl : "#",
					tooltipLinkId : "",
					tooltipLinkIcon : "icon-search",
				},
				{
					tooltipLinkText : "Facebook",
					tooltipLinkUrl : "#",
					tooltipLinkId : "",
					tooltipLinkIcon : "icon-facebook-circled",
				},
				{
					tooltipLinkText : "Twitter",
					tooltipLinkUrl : "#",
					tooltipLinkId : "",
					tooltipLinkIcon : "icon-twitter-circled",
				}]		
			},
			{
				type : "link",
				text : "Log in",
				url : "#",
				id : "",			
				cntClass : "",					
				tooltipContent : []		
			},
			{
				type : "button",
				text : "Get your offer",
				url : "#",
				id : "",			
				cntClass : "",					
				tooltipContent : []					
			}
		]
	});	
```





