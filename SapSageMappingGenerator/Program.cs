using SapSageMappingGenerator;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
 
SageFunctionGenerator.CreateSageFunction("Data/Rules/VendorMap.json", "Vendor");
SageFunctionGenerator.CreateSageFunction("Data/Rules/InvoiceMap.json", "Invoice");
 
