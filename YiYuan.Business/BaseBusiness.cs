using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EntityFramework.Extensions;
using YiYuan.Entity;

namespace YiYuan.Business
{
    /// <summary>
    ///  查询业务基实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseBusiness<T> where T : class
    {
        /// <summary>
        /// 是否跟踪上下文
        /// <para>可提升性能</para>
        /// </summary>
        public bool asNoTracking { get; set; }

        /// <summary>
        /// 数据上下文对象
        /// </summary>
        public DataBaseContext context { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payu.Business.Base.QueryBaseBusiness{T}"/> class.
        /// </summary>
        public BaseBusiness()
        {
            context = EFContextFactory.GetCurrentDbContext();
        }
        /// <summary>
        /// 设置query 查询对象
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public IQueryable<T> SetQueryable(IQueryable<T> query)
        {
            if (!this.asNoTracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        /// <summary>
        /// 设置query 查询对象
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public IQueryable<OutT> SetQueryable<OutT>(IQueryable<OutT> query) where OutT : class
        {
            if (!this.asNoTracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        /// <summary>
        /// 返回总个数.
        /// </summary>
        /// <returns></returns>
        public IBusinessResponse<Int32> GetCount()
        {

            var count = this.GetQueryable().Count();

            return new BusinessResponse<Int32>(count);
        }

        /// <summary>
        /// 根据表达式查询返回总个数.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public IBusinessResponse<Int32> GetCount(Expression<Func<T, bool>> where)
        {
            var count = this.GetQueryable(where).Count();

            return new BusinessResponse<Int32>(count);
        }


        /// <summary>
        /// 根据表达式查询返回总个数
        /// </summary>
        /// <param name="where"></param>
        /// <param name="selectExpression">统计的对象</param>
        /// <returns></returns>
        public IBusinessResponse<Int32> GetCount<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> selectExpression)
        {
            var query = this.GetQueryable(where);

            var count = query.Select(selectExpression).Count();

            return new BusinessResponse<Int32>(count);
        }

        /// <summary>
        /// 根据 where  返回集合对象
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IBusinessResponse<ICollection<T>> GetByWhere(Expression<Func<T, bool>> where)
        {
            var result = this.GetQueryable(where).ToList();

            return new BusinessResponse<ICollection<T>>(result);
        }

        /// <summary>
        /// 根据 where 条件返回 集合对象
        /// </summary>
        /// <typeparam name="TOut">返回类型</typeparam>
        /// <param name="where">查询条件.</param>
        /// <param name="selectExpression">查询表达式</param>
        /// <returns></returns>
        public IBusinessResponse<ICollection<TOut>> GetByWhere<TOut>(Expression<Func<T, bool>> where, Expression<Func<T, TOut>> selectExpression)
        {
            var query_data = this.GetQueryable().Where(where).Select(selectExpression).ToList();

            return new BusinessResponse<ICollection<TOut>>(query_data);
        }

        /// <summary>
        /// 根据 where 条件返回 集合对象
        /// </summary>
        /// <typeparam name="TOut">返回的泛型类型</typeparam>
        /// <typeparam name="TKey">排序的类型</typeparam>
        /// <param name="where">查询条件.</param>
        /// <param name="orderLambda">排序表达式</param>
        /// <param name="selectExpression">查询表达式</param>
        /// <returns></returns>
        public IBusinessResponse<ICollection<TOut>> GetByWhere<TOut, TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderLambda, Expression<Func<T, TOut>> selectExpression)
        {
            var query_data = this.GetQueryable().Where(where).OrderBy(orderLambda).Select(selectExpression).ToList();

            return new BusinessResponse<ICollection<TOut>>(query_data);
        }

        /// <summary>
        /// 根据表达式返回第一个元素
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IBusinessResponse<T> GetFirstByWhere(Expression<Func<T, bool>> where)
        {
            var entity = this.GetQueryable(where).FirstOrDefault();

            if (entity == null)
            {
                return new BusinessResponse<T>(false, "数据不存在", "Not_Data");
            }

            return new BusinessResponse<T>(entity);
        }

        /// <summary>
        /// 根据表达式返回第一个自定义元素
        /// <para>带有Select</para>
        /// </summary>
        /// <param name="where"></param>
        /// <param name="selectExpression">查询对象</param>
        /// <returns></returns>
        public IBusinessResponse<TOut> GetFirstByWhere<TOut>(Expression<Func<T, bool>> where, Expression<Func<T, TOut>> selectExpression)
        {
            var query = this.GetQueryable(where);

            var entity = query.Select(selectExpression).FirstOrDefault();

            return new BusinessResponse<TOut>(entity);
        }

        /// <summary>
        ///  获得唯一一个对象
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IBusinessResponse<T> GetSingleByWhere(Expression<Func<T, bool>> where)
        {
            var entity = context.Set<T>().Where(where).SingleOrDefault();

            if (entity == null)
            {
                return new BusinessResponse<T>(false, "数据不存在", "Not_Data");
            }
            return new BusinessResponse<T>(entity);
        }

        /// <summary>
        ///  获得唯一一个对象
        /// </summary>
        /// <param name="where"></param>
        /// <param name="selectExpression"></param>
        /// <returns></returns>
        public IBusinessResponse<TOut> GetSingleByWhere<TOut>(Expression<Func<T, bool>> where, Expression<Func<T, TOut>> selectExpression)
        {
            var entity = this.GetQueryable(where).Select(selectExpression).SingleOrDefault();

            return new BusinessResponse<TOut>(entity);
        }

        /// <summary>
        /// 根据表达式返回最后一个元素
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IBusinessResponse<T> GetLastByWhere(Expression<Func<T, bool>> where)
        {
            var query = context.Set<T>().Where(where).AsQueryable();

            var entity = query.LastOrDefault();

            if (entity == null)
            {
                return new BusinessResponse<T>(false, "数据不存在", "Not_Data");
            }

            return new BusinessResponse<T>(entity);
        }

        /// <summary>
        /// 根据表达式返回最后一个元素
        /// </summary>
        /// <typeparam name="TOut">The type of the out.</typeparam>
        /// <param name="where">The where.</param>
        /// <param name="selectExpression">The select expression.</param>
        /// <returns></returns>
        public IBusinessResponse<TOut> GetLastByWhere<TOut>(Expression<Func<T, bool>> where, Expression<Func<T, TOut>> selectExpression)
        {
            var query = this.GetQueryable(where);

            var entity = query.Select(selectExpression).LastOrDefault();

            return new BusinessResponse<TOut>(entity);
        }

        /// <summary>
        /// 数据是否存在
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IBusinessResponse<bool> AnyByWhere(Expression<Func<T, bool>> where)
        {
            var isAny = this.GetQueryable().Any(where);
            if (isAny)
            {
                return new BusinessResponse<bool>(true, "已存在", "Exist_Data")
                {
                    Data = true
                };
            }

            return new BusinessResponse<bool>(false, "不存在", "Not_Data");
        }

        /// <summary>
        /// 获得指定的查询对象
        /// </summary>
        /// <returns></returns>
        public IQueryable<TOut> GetQueryable_Out<TOut>(Expression<Func<TOut, bool>> where) where TOut : class
        {
            var query = this.context.Set<TOut>().Where(where);

            query = SetQueryable(query);

            return query;
        }

        /// <summary>
        /// 获得当前的查询对象
        /// </summary>
        /// <returns></returns>
        public IQueryable<OutT> GetQueryable_Out<OutT>() where OutT : class
        {
            var query = this.context.Set<OutT>().AsQueryable();

            query = SetQueryable(query);

            return query;
        }

        /// <summary>
        /// 执行分页
        /// </summary>
        /// <param name="query">查询对象</param>
        /// <param name="result">返回对象</param>
        /// <param name="paging">分页对象</param>
        public IPagingBusinessResponse<ICollection<OutT>> ExecutePage_Out<OutT>(IQueryable<OutT> query, IPagingBusinessResponse<ICollection<OutT>> result, Paging paging) where OutT : class
        {
            result.Data = query.Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList();

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 获得当前的查询对象
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetQueryable()
        {
            var query = this.context.Set<T>().AsQueryable();

            query = SetQueryable(query);

            return query;
        }

        /// <summary>
        /// 获得当前的查询对象
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> where)
        {
            var query = this.context.Set<T>().Where(where);

            query = SetQueryable(query);

            return query;
        }

        /// <summary>
        /// 获得当前的查询对象
        /// </summary>
        /// <returns></returns>
        public IQueryable<dynamic> GetQueryable(Expression<Func<T, bool>> where, Expression<Func<T, dynamic>> selectExpression)
        {
            var query = this.context.Set<T>().Where(where);

            query = SetQueryable(query);

            return query.Select(selectExpression);
        }

        /// <summary>
        /// 获得当前的查询对象
        /// </summary>
        /// <returns></returns>
        public IQueryable<TOut> GetQueryable<TOut>(Expression<Func<T, bool>> where, Expression<Func<T, TOut>> selectExpression)
        {
            var query = this.context.Set<T>().Where(where);

            query = SetQueryable(query);

            return query.Select(selectExpression);
        }

        /// <summary>
        /// 执行分页_动态操作
        /// </summary>
        /// <param name="query">查询对象</param>
        /// <param name="result">返回对象</param>
        /// <param name="paging">分页对象</param>
        /// <param name="selectExpression"></param>
        public IPagingBusinessResponse<dynamic> ExecutePage_Dynamic(IQueryable<T> query, IPagingBusinessResponse<dynamic> result, Paging paging, Expression<Func<T, dynamic>> selectExpression)
        {
            result.Data = query.Select(selectExpression).Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList();

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 执行分页_动态操作
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="orderLambda">排序表达式</param>
        /// <param name="codeOrderType">排序方式</param>
        /// <param name="paging">分页参数</param>
        /// <param name="selectExpression">动态类型</param>
        /// <returns></returns>
        public IPagingBusinessResponse<dynamic> ExecutePage_Dynamic<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderLambda, CodeOrderType codeOrderType, Paging paging, Expression<Func<T, dynamic>> selectExpression)
        {

            var query = this.GetQueryable(where);

            if (codeOrderType == CodeOrderType.Asc)
            {
                query = query.OrderBy(orderLambda);
            }
            else if (codeOrderType == CodeOrderType.Desc)
            {
                query = query.OrderByDescending(orderLambda);
            }

            var result = new PagingBusinessResponse<dynamic>
            {
                Data = query.Select(selectExpression).Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList()
            };

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 执行分页
        /// <para>返回动态对象</para>
        /// </summary>
        /// <param name="query">查询对象</param>
        /// <param name="paging">分页对象</param>
        /// <param name="selectExpression">动态表达式</param>
        public IPagingBusinessResponse<dynamic> ExecutePage_Dynamic(IQueryable<T> query, Paging paging, Expression<Func<T, dynamic>> selectExpression)
        {
            var result = new PagingBusinessResponse<dynamic>
            {
                Data = query.Select(selectExpression).Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList()
            };

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 执行分页
        /// </summary>
        /// <param name="query">查询对象</param>
        /// <param name="result">返回对象</param>
        /// <param name="paging">分页对象</param>
        public IPagingBusinessResponse<ICollection<T>> ExecutePage(IQueryable<T> query, IPagingBusinessResponse<ICollection<T>> result, Paging paging)
        {
            result.Data = query.Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList();

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 执行分页
        /// </summary>
        /// <param name="query">查询对象</param>
        /// <param name="paging">分页对象</param>
        public IPagingBusinessResponse<ICollection<T>> ExecutePage(IQueryable<T> query, Paging paging)
        {
            var result = new PagingBusinessResponse<ICollection<T>>
            {
                Data = query.Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList()
            };

            paging.Total = query.FutureCount().Value;

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 执行分页
        /// <para>返回传入的类型</para>
        /// </summary>
        /// <typeparam name="Tout">返回的类型</typeparam>
        /// <param name="query">当前的查询对象</param>
        /// <param name="paging">分页参数</param>
        /// <param name="selectExpression">查询表达式</param>
        /// <returns></returns>
        public IPagingBusinessResponse<ICollection<Tout>> ExecutePage<Tout>(IQueryable<T> query, Paging paging, Expression<Func<T, Tout>> selectExpression)
        {
            var result = new PagingBusinessResponse<ICollection<Tout>>
            {
                Data = query.Select(selectExpression).Skip((paging.PageIndex - 1) * paging.PageSize).Take(paging.PageSize).ToList()
            };

            // paging.Total = query.FutureCount().Value;

            paging.Total = query.Count();

            paging.PageSize = paging.PageSize;

            paging.PageIndex = paging.PageIndex;

            result.Paging = paging;

            return result;
        }

        /// <summary>
        /// 根据主键(Id)获得单个数据对象
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        public IBusinessResponse<T> GetById(dynamic id)
        {
            var entity = context.Set<T>().Find(id);

            if (entity == null)
            {
                return new BusinessResponse<T>(false, "编号" + id + "不存在", "Not_Data");
            }

            return new BusinessResponse<T>(entity);
        }


        /// <summary>
        /// Executes the select SQL.
        /// <para>执行查询语句</para>
        /// <para>返回TIn 泛型单个对象</para>
        /// </summary>
        /// <typeparam name="TIn">返回映射泛型</typeparam>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public TIn ExecSelectSql<TIn>(string sql)
        {
            return context.Database.SqlQuery<TIn>(sql).FirstOrDefault();
        }

        /// <summary>
        /// Executes the select SQL.
        /// <para>执行查询语句</para>
        /// <para>返回TIn 泛型单个对象</para>
        /// </summary>
        /// <typeparam name="TIn">返回映射泛型</typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public TIn ExecSelectSql<TIn>(string sql, params object[] parameters)
        {
            return context.Database.SqlQuery<TIn>(sql, parameters).FirstOrDefault();
        }


        /// <summary>
        /// Executes the select SQL to list.
        /// <para>执行查询语句并返回集合列表</para>
        /// <para>返回TIn 泛型集合对象</para>
        /// </summary>
        /// <typeparam name="TIn">返回映射泛型</typeparam>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public List<TIn> ExecSelectSqlToList<TIn>(string sql)
        {
            return context.Database.SqlQuery<TIn>(sql).ToList();
        }


        /// <summary>
        /// Executes the select SQL to list.
        /// <para>执行查询语句并返回集合列表</para>
        /// <para>返回TIn 泛型集合对象</para>
        /// </summary>
        /// <typeparam name="TIn">返回映射泛型</typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public List<TIn> ExecSelectSqlToList<TIn>(string sql, params object[] parameters)
        {
            return context.Database.SqlQuery<TIn>(sql, parameters).ToList();
        }


        /// <summary>
        /// Executes the select SQL to 
        /// <para>执行查询语句并返回集合列表</para>
        /// <para>返回TIn 泛型集合对象</para>
        /// </summary>
        /// <typeparam name="TIn">返回映射泛型</typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public dynamic ExecSelectSqlToTInList<TIn>(string sql, params object[] parameters)
        {
            return context.Database.SqlQuery<TIn>(sql, parameters).ToList();
        }


        /// <summary>
        /// Executes the command SQL
        /// <para>执行命令的SQL</para>
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public int ExecCommandSql(string sql, params object[] parameters)
        {
            return context.Database.ExecuteSqlCommand(sql, parameters);
        }

        /// <summary>
        /// 根据表达式删除
        /// </summary>
        /// <param name="where">where条件</param>
        /// <returns></returns>
        public IBusinessResponse<bool> Remove(Expression<Func<T, bool>> where)
        {
            return this.Remove(GetQueryable(where));
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="where">更新条件（表达式）</param>
        /// <param name="t">更新的实体类</param>
        /// <returns></returns>
        public IBusinessResponse<bool> Update(Expression<Func<T, bool>> where, T t)
        {
            var rowNumber = GetQueryable(where).Update(p => t);

            if (rowNumber == 0)
            {
                return new BusinessResponse<bool>(false, "更新失败", "Not_Row", false);
            }
            return new BusinessResponse<bool>(true, "更新成功", "Success", true);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="where">更新条件（表达式）</param>
        /// <param name="t">更新的实体类</param>
        /// <returns></returns>
        public IBusinessResponse<bool> Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> updateExpression)
        {
            var rowNumber = GetQueryable(where).Update(updateExpression);

            if (rowNumber == 0)
            {
                return new BusinessResponse<bool>(false, "更新失败", "Not_Row", false);
            }
            return new BusinessResponse<bool>(true, "更新成功", "Success", true);
        }

        /// <summary>
        /// 更新实体类
        /// <para>更新整行字段，更新前需把字段全部赋值</para>
        /// </summary>
        /// <param name="pu_model"></param>
        public void Update(T t)
        {
            context.Set<T>().Attach(t);

            var entry = context.Entry(t);

            entry.State = EntityState.Modified;

            context.SaveChanges();
        }

        /// <summary>
        /// 根据主键批量物理删除
        /// </summary>
        /// <param name="where">where条件</param>
        /// <returns></returns>
        public IBusinessResponse<bool> Delete(Expression<Func<T, bool>> where)
        {
            return this.Remove(GetQueryable(where));
        }

        /// <summary>
        /// 根据查询条件批量物理删除
        /// </summary>
        /// <param name="queryable">可查询对象</param>
        /// <returns></returns>
        public IBusinessResponse<bool> Remove(IQueryable<T> queryable)
        {
            var rowNumber = queryable.Delete();

            if (rowNumber == 0)
            {
                return new BusinessResponse<bool>(false, "删除失败", "Not_Row", false);
            }
            return new BusinessResponse<bool>(true, "删除成功", "Success", true);
        }

        /// <summary>
        /// 批量添加
        /// http://www.tuicool.com/articles/iyYbiqe
        /// </summary>
        /// <param name="list"></param>
        public void AddList(IList<T> list)
        {
            //context.BulkInsert(list);

            //context.BulkSaveChanges();

            context.Set<T>().AddRange(list);
            context.SaveChanges();
        }


        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">要新增的实体</param>
        /// <param name="IsSubmit">是否马上提交</param>
        public T Add(T entity, bool IsSubmit = true)
        {
            var resultEntity = context.Set<T>().Add(entity);

            var rowNumber = 0;

            if (IsSubmit)
            {
                rowNumber = context.SaveChanges();
            }

            return resultEntity;
        }


        /// <summary>
        /// 异步添加
        /// </summary>
        /// <param name="t"></param>
        public void AddAsync(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChangesAsync();
        }


        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">要新增的实体</param>
        /// <param name="IsSubmit">是否马上提交</param>
        public T Create(T entity, bool IsSubmit = true)
        {
            var resultEntity = context.Set<T>().Add(entity);

            var rowNumber = 0;

            if (IsSubmit)
            {
                rowNumber = context.SaveChanges();
            }

            return resultEntity;
        }


        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="list">实体集合</param>
        public void Add(IList<T> list)
        {
            context.Set<T>().AddRange(list);
            context.SaveChanges();
        }

    }
}