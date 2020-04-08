﻿using System;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                SortArrayInAscendingOrder(array);
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (!IsArrayNullOrEmpty(array))
            {
                int[] buffer = new int[array.Length];
                int numberofIterations = 0;

                for (int i = (array.Length - 1); i >= 0; i--)
                {
                    buffer[numberofIterations] = array[i];
                    numberofIterations++;
                }

                array = buffer;

                //for (int i = 0; i < array.Length / 2; i++)
                //{
                //    int buffer = array[i];
                //    array[i] = array[array.Length - i - 1];
                //    array[array.Length - i - 1] = buffer;
                //}
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            return array;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {            
            if (!IsArrayNullOrEmpty(array) && !IsIndexOutOfRange(array, index))
            {
                int bufferSize = array.Length - 1;
                int[] buffer = new int[bufferSize];

                for (int i = 0; i < bufferSize; i++)
                {
                    buffer[i] = i < index ? array[i] : array[i + 1];
                }

                return buffer;
            }

            return array;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            // ToDo: implement.
            return array;
        }

        /// <summary>
        /// Sorts the given array in ascending order using the bubble sort algorhythm.
        /// </summary>
        /// <param name="array">The array that will be sorted.</param>
        private static void SortArrayInAscendingOrder(int[] array)
        {
            while (true)
            {
                int numberOfSwaps = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int buffer = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buffer;

                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Validates an array by checking whether it's empty or null.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Returns the boolean representation whether the array is valid or not.</returns>
        private static bool IsArrayNullOrEmpty(int[] array)
        {
            if (array == null)
                return true;

            if (array.Length == 0)
                return true;

            return false;
        }

        /// <summary>
        /// Validates an array by checking whether it's empty or null, or if the passed index is out of range.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index which should be checked whether it is in range of the input array or not.</param>
        /// <returns>Returns the boolean representation whether the array is valid or not.</returns>
        private static bool IsIndexOutOfRange(int[] array, int index)
        {
            if (index > (array.Length - 1) || index < 0)
                return true;

            return false;
        }
    }
}
