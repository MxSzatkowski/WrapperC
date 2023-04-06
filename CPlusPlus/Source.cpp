#define MyFunctions _declspec(dllexport)

extern "C" {
	MyFunctions int AddNumbers()
	{
		int a = 10;
		int b = 20;
		return a + b;
	}
}