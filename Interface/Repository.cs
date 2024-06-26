﻿using System.Windows.Forms;

namespace AutoService.Interface
{
    public interface Repository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SearchSelect(Control control, DataGridView dataGridView);
        void SelectAllFields(DataGridView dataGridView);
    }
}
