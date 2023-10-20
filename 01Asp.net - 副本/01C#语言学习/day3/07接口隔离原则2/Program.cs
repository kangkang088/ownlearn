using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;

namespace _07接口隔离原则2 {
    internal class Program {
        static void Main(string[] args) {
            int[] num1 = { 1, 2, 3, 4, 5 };
            ArrayList num2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Sum(num2));
            

            var roc = new ReadOnlyCollection(num1);

            Console.WriteLine(Sum(roc));

        }
        static int Sum(IEnumerable nums) {
            int sum = 0;
            foreach (var c in nums) {
                sum += (int)c;
            }
            return sum;
        }
    }
    class ReadOnlyCollection : IEnumerable {
        private int[] _array;
        public ReadOnlyCollection(int[] array) {
            _array = array;
        }

        public IEnumerator GetEnumerator() {
            return new Enumerator(this);
        }
        public class Enumerator : IEnumerator {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection) {
                _collection = collection;
                _head = -1;
            }

            public object Current {
                get {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext() {
                if (++_head < _collection._array.Length) {
                    return true;
                }
                else {
                    return false;
                }
            }

            public void Reset() {
                _head = -1;
            }
        }
    }
}
