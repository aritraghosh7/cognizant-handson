import React from 'react';

const ListOfPlayers = () => {
  const players = [
    { name: "Virat", score: 85 },
    { name: "Rohit", score: 45 },
    { name: "Rahul", score: 75 },
    { name: "Shreyas", score: 60 },
    { name: "Pant", score: 90 },
    { name: "Jadeja", score: 55 },
    { name: "Ashwin", score: 88 },
    { name: "Shami", score: 40 },
    { name: "Bumrah", score: 78 },
    { name: "Surya", score: 35 },
    { name: "Gill", score: 95 },
  ];

  const below70 = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>
        {players.map((p, i) => (
          <li key={i}>{p.name} - {p.score}</li>
        ))}
      </ul>

      <h2>Players with Score below 70:</h2>
      <ul>
        {below70.map((p, i) => (
          <li key={i}>{p.name} - {p.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListOfPlayers;
