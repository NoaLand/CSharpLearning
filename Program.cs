using CSharpLearning;
using CSharpLearning.DataStructure;
using CSharpLearning.MemoryManagement;

IOExample.Run();

ListExample.Run();
ArrayExample.Run();
QueueExample.RunNonGenericExample();
QueueExample.RunGenericExample();

PassByRefAndValueExample passByRefAndValueExample = new PassByRefAndValueExample();
passByRefAndValueExample.RunWithPassByValue();
passByRefAndValueExample.RunWithPassByRef();