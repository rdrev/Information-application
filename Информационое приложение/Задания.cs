//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Информационое_приложение
{
    using System;
    using System.Collections.Generic;
    
    public partial class Задания
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Задания()
        {
            this.СписокИсполнителей = new HashSet<СписокИсполнителей>();
        }
    
        public int КодЗадание { get; set; }
        public string НазваниеЗадачи { get; set; }
        public System.DateTime Начало { get; set; }
        public System.DateTime Оканчание { get; set; }
        public int СтатусЗадание { get; set; }
        public Nullable<int> Клиент { get; set; }
        public string КоммениарийЗадание { get; set; }
        public int Отрасаль { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        public virtual Отрасли Отрасли { get; set; }
        public virtual Статусы Статусы { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СписокИсполнителей> СписокИсполнителей { get; set; }
    }
}
