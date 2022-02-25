const deleteBtns = document.querySelectorAll('.deleteBtn');
const url = 'api/gamesapi/deletegame/';

const deleteMethod = (id) => {
	fetch(url + id, {
		method: 'delete',
	}).then(location.reload());
};

deleteBtns.forEach((deleteBtn) =>
	deleteBtn.addEventListener(
		'click',
		async (btn) => await deleteMethod(btn.target.dataset.id)
	)
);
