import React from 'react';

const IndianPlayers = () => {
  const T20players = ['Virat', 'Rohit', 'Rahul', 'Surya'];
  const RanjiTrophy = ['Shreyas', 'Pant', 'Jadeja'];

  const allPlayers = [...T20players, ...RanjiTrophy];

  const [player1, player2, player3, player4, player5, player6, player7] = allPlayers;

  const oddPlayers = [player1, player3, player5, player7].filter(Boolean);
  const evenPlayers = [player2, player4, player6].filter(Boolean);

  return (
    <div>
      <h2>Merged Player List:</h2>
      <ul>{allPlayers.map((p, i) => <li key={i}>{p}</li>)}</ul>

      <h3>Odd Team Players:</h3>
      <ul>{oddPlayers.map((p, i) => <li key={i}>{p}</li>)}</ul>

      <h3>Even Team Players:</h3>
      <ul>{evenPlayers.map((p, i) => <li key={i}>{p}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;
