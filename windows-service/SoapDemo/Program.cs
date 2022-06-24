using ServiceReferenceDemo;

var proxy = new HelloEndpointClient();
var request = new helloRequest
{
    Name = "aldriguz"
};

var bodyRequest = new SayHello(request);

var response = await proxy.SayHelloAsync(bodyRequest);
Console.WriteLine(response.HelloResponse.Message);
