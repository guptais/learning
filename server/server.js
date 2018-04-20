import http from 'http'; //to create a http based server/client. Here we are using to create a server
import fs from 'fs'; //FileSystem module to help us with file/folders related operations
import url from 'url';//Uniform Resource Locator module to help us with URL related operations
import path from 'path'; //File System path module to help us with path related operations.

/**
 * Function to be used as a callback to our http.createServer method
 * It handles incoming requests and sends the response
 */
function requestHandler(request, response)
{
    //resolve the path to the requested resource and assign it to a variable
    let requestedResource = path.join(
        __dirname, 
        '../public',
        url.parse(request.url).pathname);

    const callbackFunc = function (exists) 
    {
        // check if file does't exist and return a 404 status (File not found)
        if (!exists) 
        {
            response.writeHead(404, { "Content-Type": "text/plain" });
            response.write("404 Not Found\n");
            response.end();
            return;
        }
        if (fs.statSync(requestedResource).isDirectory()) 
        {
            requestedResource += '/index.html';
        }
        fs.readFile(requestedResource, "binary", 
                    function (err, file) 
                    {
                        //If an error occured while reading the file, send the error message
                        // with a status code of 500 ( Internal server error)
                        if (err)
                        {
                            response.writeHead(500, {"Content-Type": "text/plain"});
                            response.write(err + "\n");
                            response.end();
                            return;
                        }
                        // Helper object to map requested content types (extension) 
                        // to response mime types
                        const contentTypesByExtension = 
                        {
                            '.html': "text/html",
                            '.css': "text/css",
                            '.js':"text/javascript"
                        };

                        //Helper object to hold our headers
                        const headers = {};
                        //get the content type using the requested resource file extension
                        const contentType = contentTypesByExtension[path.extname(requestedResource)];

                        if(contentType) 
                        {
                            headers["Content-Type"] = contentType;
                        }

                        response.writeHead(200, headers); // write response header
                        response.write(file, "binary"); //write content of read file (binary format)
                        response.end(); // send response and close request
                    });
    };

    // use the exists method of the fs module to check if the requestedResource
    // exists.
    fs.exists(requestedResource, callbackFunc);
}

//create an instance of out httpServer and passing in our request handler callback
const server = http.createServer(requestHandler);

//declare our port number
const portNumber = 3030;

//setup our server to start listening on the port we specified
server.listen(portNumber, function() {
    //log to our console, so we know our server is up and running.
    console.log('Server Listening on port ', portNumber);
});
