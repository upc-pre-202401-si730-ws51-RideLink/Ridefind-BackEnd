﻿namespace RideFind_BackEnd.Orders.Domain.Model.Commands;

public record CreateOrderCommand(string OwnerName, string SelectedPlan,double Discount, double Subtotal, double Total);