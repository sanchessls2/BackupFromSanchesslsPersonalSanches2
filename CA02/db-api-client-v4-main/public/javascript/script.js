
// API Base URL - the server address
const BASE_URL = `http://localhost:8080`;

function getHeaders() {
  // Return headers
  // Note that the access token is set in the Authorization: Bearer
  return new Headers({
    "Accept": "application/json",
    "Content-Type": "application/json",
    "Authorization": "Bearer " + getAccessToken()
  });
}

// Asynchronous Function getDataAsync from a url and return
async function getDataAsync(url) {

  // Requests will use the GET method and permit cross origin requests
  const GET_INIT = { method: 'GET', credentials: 'include', headers: getHeaders(), mode: 'cors', cache: 'default' };

  // Try catch 
  try {
    // Call fetch and await the respose
    // Initally returns a promise
    const response = await fetch(url, GET_INIT);

    // As Resonse is dependant on fetch, await must also be used here
    const json = await response.json();

    // Output result to console (for testing purposes) 
    //console.log(json);

    // Call function( passing he json result) to display data in HTML page
    //displayData(json);
    return json;

    // catch and log any errors
  } catch (err) {
    console.log(err);
    return null;
  }
}