using SapSageMappingGenerator;

Console.WriteLine("Hello, World!");


//var body = SageFunctionGenerator.GetFunctionBody("Data/Rules/VendorMap.json"); 

var invoiceBody = SageFunctionGenerator.GetFunctionBody("Data/Rules/InvoiceMap.json");
Console.WriteLine(invoiceBody);


