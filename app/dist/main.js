var app, express, server;

express = require('express');

app = express();

app.get('/', function(req, res) {
  return res.send('Hello world');
});

server = app.listen(1337, function() {
  var host, port;
  host = server.address().address;
  port = server.address().port;
  return console.log('Chattr started listening at port %s', port);
});
