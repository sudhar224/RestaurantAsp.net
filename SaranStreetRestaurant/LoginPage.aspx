<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SaranStreetRestaurant.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    	<meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Simple House - Contact Page</title>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400" rel="stylesheet" />
    <link href="css/all.min.css" rel="stylesheet" />
	<link href="css/templatemo-style.css" rel="stylesheet" />
</head>
<body>
       	<div class="container">
	<!-- Top box -->
		<!-- Logo & Site Name -->
		<div class="placeholder">
			<div class="parallax-window" data-parallax="scroll" data-image-src="img/Resturant img.jpg">
				<div class="tm-header">
					<div class="row tm-header-inner">
						<div class="col-md-6 col-12">
							<img src="img/simple-house-logo.png" alt="Logo" class="tm-site-logo" /> 
							<div class="tm-site-text-box">
								<h1 class="tm-site-title">Saran Street Restaurant</h1>
								<h6 class="tm-site-description">Simple House</h6>	
							</div>
						</div>
						<nav class="col-md-6 col-12 tm-nav">
							<ul class="tm-nav-ul">
								<li class="tm-nav-li"><a href="index.aspx" class="tm-nav-link">Home</a></li>
								<li class="tm-nav-li"><a href="about.aspx" class="tm-nav-link">About</a></li>
								<li class="tm-nav-li"><a href="contact.aspx" class="tm-nav-link active">Contact</a></li>
							</ul>
						</nav>	
					</div>
				</div>
			</div>
		</div>

		<main style="background-color:lawngreen;" >
			<header class="row tm-welcome-section">
				<h2 class="col-12 text-center tm-section-title">Login Page</h2>
				
			</header>

			<div class="tm-container-inner-2 tm-contact-section" >
				<div class="row">
					<div class="col-md-6">
						<form action="" runat ="server" method="POST" class="tm-contact-form" >
					        <div class="form-group">
					          
								<asp:TextBox type="text" name="User Name" ID="txt_username" runat="server" class="form-control" placeholder="UserName" required=""></asp:TextBox>
					        </div>
					        
					        <div class="form-group">
					         
								<asp:TextBox  type="password" name="Password" class="form-control" placeholder="Password" required="" ID="txt_pwd" runat="server"></asp:TextBox>
					        </div>
				
					       
					
					        <div class="form-group tm-d-flex">
					       
								  <asp:Button ID="Button1" runat="server" Text="Submit" class="tm-btn tm-btn-success tm-btn-right" OnClick="Button1_Click"  />
					            
					          
					        </div>
						</form>
					</div>
					<div class="col-md-6">
						
							
						</div>
					</div>
				</div>
			</div>
            

					
			
			
		</main>

		<footer class="tm-footer text-center">
			<p>Copyright &copy; 2024 Saran Street Restaurant
            
           
		</footer>
	</div>
	<script src="js/jquery.min.js"></script>
	<script src="js/parallax.min.js"></script>
	<script>
		$(document).ready(function(){
			var acc = document.getElementsByClassName("accordion");
			var i;
			
			for (i = 0; i < acc.length; i++) {
			  acc[i].addEventListener("click", function() {
			    this.classList.toggle("active");
			    var panel = this.nextElementSibling;
			    if (panel.style.maxHeight) {
			      panel.style.maxHeight = null;
			    } else {
			      panel.style.maxHeight = panel.scrollHeight + "px";
			    }
			  });
			}	
		});
    </script>
</body>
</html>
