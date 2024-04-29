namespace decorator
{
    public abstract class Pizza
    {
        public string size;

        public string description;

        public Pizza(){
            description = "Unknown pizza";
        }
         
         public virtual string GetDescription(){
            return $"{size} {description}";
         }

         public virtual void SetSize(string size){
                this.size = size;
         }

         public virtual string GetSize(){
              return size;
         }

         public abstract double Cost();
    }
}