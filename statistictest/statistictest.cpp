#include "pch.h"
#include "CppUnitTest.h"
#include "../Data_layer/Statistics.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace statistictest
{
	TEST_CLASS(statistictest)
	{
	public:
		
		TEST_METHOD(getset)
		{
			Statistics tester;
			int num;
			srand(time(0));
			for (int i = 0; i < 10; i++) {
				num = rand();
				tester.setBlocks(num);
				Assert::AreEqual(num, tester.getBlocks());
			}
		}
		TEST_METHOD(saving)
		{
			int num;
			srand(time(0));
			for (int i = 0; i < 10; i++) {
				num = rand();
				Statistics tester;
				tester.setBlocks(num);
				Statistics tester2;
				Assert::AreEqual(tester2.getBlocks(), tester.getBlocks());
			}
		}
	};
}
