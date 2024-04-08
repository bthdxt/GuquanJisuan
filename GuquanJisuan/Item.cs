using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuquanJisuan
{
    public class Item
    {
        protected Dictionary<Item,float> fuItem = new Dictionary<Item,float>();
        protected Dictionary<Item,float> ziItem = new Dictionary<Item,float>();

        public string name;
        //public string waizi;
        
        public Item() {
        
        }
        public Item(string name)
        {
            this.name = name;
        }

        public void AddFuItem(Item item,float gufen)
        {
            fuItem.Add(item, gufen);
            item.ziItem.Add(this, gufen);
        }

        public void AddZiItem(Item item,float gufen)
        {
            ziItem.Add(item, gufen);
            item.fuItem.Add(this, gufen);
        }
        public int GetFuItemCount()
        {
            return fuItem.Count;
        }
        public int GetZiItemCount() 
        { 
            return ziItem.Count; 
        }    
        
        public float GetZiGufenBi(Item item)
        {
            if (item == this)
            {
                return 0;
            }
            if (this.ziItem.Count == 0)
            {
                return 0;
            }
            float zhanbi = 0;
            foreach (var zi in ziItem)
            {
                if (zi.Key == item)
                {
                    zhanbi += zi.Value;
                }
                
                zhanbi += zi.Key.GetZiGufenBi(item) * zi.Value;
            }
            return zhanbi;
        }
    }
}
