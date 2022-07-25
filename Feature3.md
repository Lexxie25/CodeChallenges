Authorization for an API

Here are a few ways to provide some basic Authorization for your API. 
It can also be called Authentication; these are sometimes interchanged with each other. But they can and should  be different.
Authorization in the basic terms are, Who are pretending to be and are you allowed to use this. 
Authentication: Who are you? Username and Password. 

HTTP Basic

The first and most simple is having HTTP basic Authorization. 
This uses a base64 encoding technique. It will pass along the login credentials, the password and username in the header. 
This will be sent to the API to make sure the user is allowed to access the site. 
This will also support HTTPS. It will encrypt it through the HTTP protocol, 
It is the simplest technique for enforcing access to the web API. it does not require cookies or identifiers for your session. 
Not the best for an API that has a lot of traffic or holds important information from users info or your code. 


Auth0 / OAuth

This service is much more secure as it is a company that has spent time and money to make a product that is easy but secure for a bunch of users. 
It is more secure for users as that the API never has access to the user's password. 
So your site has less to worry about from the user's information being taken. 
This service allows you to create roles for the different access users, from admin to individual users permissions. 
It can keep things secure behind permissions for certain access points in the API.
This is a token based Authorization. The user will access the Auth0 signin portal and get a token that your API will approve to access the site. 
Auth0 will provide Authorization and Authentication, not every provider will do this. 


