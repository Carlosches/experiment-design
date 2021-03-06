﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortTest
{
    [TestClass]
    public class MergeSortTest
    {

        private int[] testArray;
        private MergeSortAlgorithm<int> merge;

        private void SetupScenery1()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10];
            testArray[0] = 8;
            testArray[1] = 1;
            testArray[2] = 5;
            testArray[3] = 3;
            testArray[4] = 0;
            testArray[5] = 12;
            testArray[6] = 2;
            testArray[7] = 21;
            testArray[8] = 19;
            testArray[9] = 6;
        }

        private void SetupScenery2()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10];
            testArray[0] = 1;
            testArray[1] = 2;
            testArray[2] = 3;
            testArray[3] = 4;
            testArray[4] = 5;
            testArray[5] = 7;
            testArray[6] = 8;
            testArray[7] = 9;
            testArray[8] = 12;
            testArray[9] = 15;
        }

        private void SetupScenery3()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10];
            testArray[0] = 18;
            testArray[1] = 13;
            testArray[2] = 11;
            testArray[3] = 9;
            testArray[4] = 8;
            testArray[5] = 7;
            testArray[6] = 5;
            testArray[7] = 4;
            testArray[8] = 2;
            testArray[9] = 1;
        }

        private void SetupScenery4()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                testArray[i] = rnd.Next(1, 1000001);
            }
        }

        private void SetupScenery5()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                testArray[i] = i + 1;
            }
        }

        private void SetupScenery6()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100];
            int cnt = 100;
            for (int i = 0; i < 100; i++)
            {
                testArray[i] = cnt;
                cnt--;
            }
        }

        private void SetupScenery7()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                testArray[i] = rnd.Next(1, 1000001);
            }
        }

        private void SetupScenery8()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                testArray[i] = i + 1;
            }
        }

        private void SetupScenery9()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[1000];
            int cnt = 1000;
            for (int i = 0; i < 1000; i++)
            {
                testArray[i] = cnt;
                cnt--;
            }
        }

        private void SetupScenery10()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10000];
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                testArray[i] = rnd.Next(1, 1000001);
            }
        }

        private void SetupScenery11()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                testArray[i] = i + 1;
            }
        }

        private void SetupScenery12()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[10000];
            int cnt = 10000;
            for (int i = 0; i < 10000; i++)
            {
                testArray[i] = cnt;
                cnt--;
            }
        }

        private void SetupScenery13()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100000];
            Random rnd = new Random();
            for (int i = 0; i < 100000; i++)
            {
                testArray[i] = rnd.Next(1, 1000001);
            }
        }

        private void SetupScenery14()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                testArray[i] = i + 1;
            }
        }

        private void SetupScenery15()
        {
            merge = new MergeSortAlgorithm<int>(new MyComparer());
            testArray = new int[100000];
            int cnt = 100000;
            for (int i = 0; i < 100000; i++)
            {
                testArray[i] = cnt;
                cnt--;
            }
        }

        [TestMethod]
        public void TenElementsRandomOrderTest()
        {
            SetupScenery1();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void TenElementsAscendingOrderTest()
        {
            SetupScenery2();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void TenElementsDescendingOrderTest()
        {
            SetupScenery3();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredElementsRandomOrderTest()
        {
            SetupScenery4();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredElementsAscendingOrderTest()
        {
            SetupScenery5();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredElementsDescendingOrderTest()
        {
            SetupScenery6();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void ThousandElementsRandomOrderTest()
        {
            SetupScenery7();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void ThousandElementsAscendingOrderTest()
        {
            SetupScenery8();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void ThousandElementsDescendingOrderTest()
        {
            SetupScenery9();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void TenThousandElementsRandomOrderTest()
        {
            SetupScenery10();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void TenThousandElementsAscendingOrderTest()
        {
            SetupScenery11();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void TenThousandElementsDescendingOrderTest()
        {
            SetupScenery12();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredThousandElementsRandomOrderTest()
        {
            SetupScenery13();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredThousandElementsAscendingOrderTest()
        {
            SetupScenery14();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }

        [TestMethod]
        public void HundredThousandElementsDescendingOrderTest()
        {
            SetupScenery15();
            merge.MergeSort(testArray, 0, testArray.Length - 1);
            int[] newArray = testArray;
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                Assert.IsTrue(newArray[i] <= newArray[i + 1]);
            }
        }
    }
}
