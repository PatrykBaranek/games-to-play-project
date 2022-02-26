const deleteBtns = document.querySelectorAll('.deleteBtn');
const url = 'api/gamesapi/deletegame/';

const deleteMethod = async (id) => {
        const response = await fetch(url + id, {
            method: 'delete',
        })
        if (response.ok) {
            window.location.reload();
        }
};

deleteBtns.forEach((deleteBtn) =>
    deleteBtn.addEventListener(
        'click',
        async (btn) => {
            await deleteMethod(btn.target.dataset.id)
        }
    )
);
