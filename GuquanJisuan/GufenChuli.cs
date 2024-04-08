using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuquanJisuan
{
    public class GufenChuli
    {
        public List<Item> items = new List<Item>();

        public void CsvAddToItem(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] strs = lines[i].Split(',');
                if (!FindItem(strs[1]))
                {
                    Item item = new Item(strs[1]);
                    items.Add(item);
                }
                if (!FindItem(strs[0]))
                {
                    Item item = new Item(strs[0]);
                    items.Add(item);
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string[] strs = lines[i].Split(',');
                Item itemFu = GetItem(strs[0]);
                Item itemZi = GetItem(strs[1]);
                if (itemFu != null && itemZi != null)
                {
                    itemFu.AddZiItem(itemZi, float.Parse(strs[2]));
                } else
                {
                    Console.WriteLine("添加失败" + lines[i]);
                }
            }
        }

        public bool FindItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    return true;
                }
            }
            return false;
        }
        public Item GetItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    return items[i];
                }
            }
            return null;
        }

        public float GetGuFenBi(string name0, string name1)
        {
            //return GetItem(name0).GetZiGufenBi(GetItem(name1));
            return GetGuFenBi(GetItem(name0), GetItem(name1));
        }
        public float GetGuFenBi(Item item0, Item item1)
        {
            return item0.GetZiGufenBi(item1);
        }
        public List<Item> GetItemList()
        {
            return items;
        }
        public string[] GetItemListNameStr()
        {
            string[] strs = new string[items.Count];
            for (int i = 0;i < items.Count; i++)
            {
                strs[i] = items[i].name;
            }
            return strs;
        }


        public string GetGuFenBiAllZiranren(string itemName, int xiaoshu)
        {
            return GetGuFenBiAllZiranren(GetItem(itemName), xiaoshu);
        }
        public string GetGuFenBiAllZiranren(Item item, int xiaoshu)
        {
            string str = "";
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].GetFuItemCount() == 0)
                {
                    str += items[i].name + "," + Math.Round(items[i].GetZiGufenBi(item), xiaoshu) + "\r\n";
                }
            }

            return str;
        }
        public string GetGuFenBiAll(string itemName, int xiaoshu)
        {
            return GetGuFenBiAll(GetItem(itemName), xiaoshu);
        }
        public string GetGuFenBiAll(Item item, int xiaoshu)
        {
            string str = "";
            for (int i = 0; i < items.Count; i++)
            {

                str += items[i].name + "," + Math.Round(items[i].GetZiGufenBi(item), xiaoshu) + ",";

                if (items[i].GetFuItemCount() != 0)
                {
                    str += "中间公司";
                }
                str += "\r\n";
            }

            return str;
        }
    }

}
