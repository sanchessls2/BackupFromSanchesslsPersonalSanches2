// Dependencies
const jwt = require("express-jwt");
const jwksRsa = require("jwks-rsa");
const jwtAuthz = require('express-jwt-authz');


// Configuration settings
const authConfig = require("../config/auth_config.json");
 
// Authentication
//
// create the JWT middleware
const checkJwt = jwt({
    // Gets the JSON Web Key Set which will be used to verify the access token and issuer.
    // Sets other required parameters including the algorithm to be used 
    secret: jwksRsa.expressJwtSecret({
      cache: true,
      rateLimit: true,
      jwksRequestsPerMinute: 5,
      jwksUri: `${authConfig.issuer}.well-known/jwks.json`
    }),
  
    audience: authConfig.audience,
    scope: 'openid email profile',
    issuer: authConfig.issuer,
    algorithms: authConfig.algorithms
  });

//
// Authorisation
// Verify that the JWT includes scpecific permissions, passed as a parameter
//
// https://github.com/auth0/express-jwt-authz#user-content-options
// https://medium.com/javascript-in-plain-english/securing-a-node-js-api-with-auth0-7785a8f2c8e3
const checkAuth = (permissions) => jwtAuthz(permissions, {customScopeKey: "permissions" });
// ,checkAllScopes: true 


// Export
module.exports = {
  authConfig,
  checkJwt,
  checkAuth,
};