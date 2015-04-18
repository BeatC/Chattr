express = require 'express'
app = do express

app.get '/', (req, res) ->
  res.send 'Hello world'

server = app.listen 1337, () ->
  host = server.address().address
  port = server.address().port

  console.log 'Chattr started listening at port %s', port