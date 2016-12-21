import React, { PropTypes } from 'react';

const Stats = props => {
  const playerCount = props.players.length;
  const totalPoints = props.players.reduce((total, player) => {
    retun total + player.score;
  }, 0);

  return (
    <table className="stats">
      <tbody>
        <tr>
          <td>Players: </td>
          <td>{ playerCount }</td>
        </tr>
        <tr>
          <td>Total Points:</td>
          <td>{ totalPoints }</td>
        </tr>
      </tbody>
    </table>
  );
};

Stats.propTypes = {
  players: PropTypes.array.isRequired
};

export default Stats;
