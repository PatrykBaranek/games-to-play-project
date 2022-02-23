const form = document.querySelector('form');

const id = document.querySelector('#title').dataset.id;

form.addEventListener('submit', async (e) => {
	e.preventDefault();

	const formData = {
		title: document.querySelector('#title').value,
		timeSpent: document.querySelector('#timeSpent').value,
		imgUrl: document.querySelector('#imgUrl').value,
		isFinished: document.querySelector('#isFinished').value,
	};

	const putMethod = {
		method: 'PUT',
		headers: {
			'Content-type': 'application/json; charset=UTF-8',
		},
		body: JSON.stringify(formData),
	};

	console.log(formData);

	await fetch('/api/GamesApi/EditGame/' + id, putMethod)
		.then((response) => response.json())
		.then((data) => console.log(data))
		.catch((err) => console.log(err));
});
