using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex522
{
 
    class DataNumber
    {
        public ObservableCollection<int> col = new ObservableCollection<int>();
        Random r = new Random();

        public void AddElemnt()
        {
            for (int i = 0; i < 50; i++)
            {
                col.Add(r.Next(100, 1200));
            }
        }

        public async void Mix()
        {
            int count = col.Count;
            for (int i = 0; i < count; i++)
            {
                int pos = r.Next(i, count);

                int t = col[i];
                col[i] = col[pos];
                col[pos] = t;
                await Task.Delay(10);
            }
        }

        public async void Sort()
        {
            for (int i = 0; i < col.Count - 1; i++)
            {
                int index = i;
                for (int j = i; j < col.Count; j++)
                {
                    if (col[j] < col[index]) index = j;
                }

                await Task.Delay(5);
                int t = col[i];
                col[i] = col[index];
                col[index] = t;
            }
        }

        public async void BSort()
        {
            for (int i = 0; i < col.Count - 2; i++)
            {
                int index = i;
                for (int j = 0; j < col.Count-1; j++)
                {
                    if (col[j] > col[j+1])
                    {
                        int t = col[j];
                        col[j] = col[j+1];
                        col[j + 1] = t;
                        await Task.Delay(1);
                    }
                }
                
            }
        }


        public async void ShakerSort()
        {
            int left = 0,
                right = col.Count - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (col[i] > col[i + 1])
                    {
                        int t = col[i];
                        col[i] = col[i + 1];
                        col[i + 1] = t;
                    }
                    await Task.Delay(1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (col[i - 1] > col[i])
                    {
                        int t = col[i-1];
                        col[i-1] = col[i];
                        col[i ] = t;

                    }
                    await Task.Delay(1);

                }
                left++;
            }
            
        }


    }


}
