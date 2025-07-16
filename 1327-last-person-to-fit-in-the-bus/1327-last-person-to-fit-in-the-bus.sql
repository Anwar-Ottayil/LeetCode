/* Write your T-SQL query statement below */
WITH CumulativeWeight AS (
  SELECT *,
         SUM(weight) OVER (ORDER BY turn) AS running_weight
  FROM Queue
)
SELECT TOP 1 person_name
FROM CumulativeWeight
WHERE running_weight <= 1000
ORDER BY running_weight DESC;