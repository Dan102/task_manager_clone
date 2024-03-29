using System;
using System.Collections.Generic;
using task_manager_api.Dtos;
using task_manager_api.Models;

namespace task_manager_api.Repository
{
    public interface ICardRepository
    {
        bool CreateCard(int listId, string title, string? description, int? priority, DateTime? deadline);
        bool DeleteCard(int id);
        bool UpdateCard(int id, Card card);
        bool UpdateCards(List<CardsUpdateDto> card);
    }
}