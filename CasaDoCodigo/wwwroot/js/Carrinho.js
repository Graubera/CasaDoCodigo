function clickIncremento(btn) {
    alert(btn);
}
function clickDecremento(btn) {
    var linhaDoItem = $(btn).parents('[item-id]');
    var itemId = linhaDoItem.attr('item-id');
    var novaQtde = linhaDoItem.find('input').val();
    var ItemPedido = {
        Id: itemId,
        Quantidade: novaQtde
    };

    $.ajax({
        url: '@Url.Action("PostQuantidade", "Pedido")',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(ItemPedido)
    })
}