﻿using apiCaptar.Data.ValueObjects;

namespace apiCaptar.Repository.Interface;

public interface IpesquisaRepository
{
    Task<IEnumerable<pesquisaVO>> FindAll();
    Task<pesquisaVO> FindById(long id);
    Task<pesquisaVO> Create(pesquisaVO vo);
    Task<pesquisaVO> Update(pesquisaVO vo);
    Task<bool> Delete(long id);
}
