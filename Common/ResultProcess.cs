using System.Collections.Generic;
using Comp4920_SAS.Models;

namespace Comp4920_SAS.Common
{
    public class ResultProcess<T>
    {
        public Result<int> GetResult(DataContext db)
        {
            Result<int> result = new Result<int>();
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                result.UserMessage = "Basarili";
                result.IsSuccessed = true;
                result.ProcessResult = sonuc;
            }
            else
            {
                result.UserMessage = "Basarisiz";
                result.IsSuccessed = false;
                result.ProcessResult = sonuc;
            }
            return result;
        }
        public Result<List<T>> GetListResult(List<T> data)
        {
            Result<List<T>> result = new Result<List<T>>();
            if (data != null)
            {
                result.UserMessage = "islem Basarili";
                result.IsSuccessed = true;
                result.ProcessResult = data;
            }
            else
            {
                result.UserMessage = "islem basarisiz data yok";
                result.IsSuccessed = false;
                result.ProcessResult = data;
            }
            return result;
        }

        public Result<T> GetT(T data)
        {
            Result<T> result = new Result<T>();
            if (data != null)
            {
                result.IsSuccessed = true;
                result.UserMessage = "Basarili";
                result.ProcessResult = data;
            }
            else
            {
                result.IsSuccessed = false;
                result.UserMessage = "Basarisiz";
                result.ProcessResult = data;
            }
            return result;
        }
    }
}